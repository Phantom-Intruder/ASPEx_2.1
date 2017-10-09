
/*
	This script will produce a create index script for each column that ends with "_id" (i.e. foreign key notation as of the framework).
	Copy the IndexString column into a new window and execute to create indices. Please note that some tables may not require these indices 
	by default (e.g. SystemLogged table where only insert, update operations are mainly done and data accessing is zero or insignificant, 
	having indices for those tables can be counter-effective). Please remove those tables and/or indices manually from the list.
*/

-- Copy/paste IndexString to a different window and run

DECLARE @Statement VARCHAR(2000)
DECLARE @TableName VARCHAR(100)
DECLARE @ColumnName VARCHAR(100)
DECLARE @Count int
SET @Count = 0;
DECLARE DatabaseCursor CURSOR FOR  
SELECT COL.Table_Name               AS TableName,
      QUOTENAME(Column_Name)        AS ColumnName,
      'IF indexproperty(object_id(''' + COL.Table_Name + '''), ''IX_' + COL.Table_Name + '_' + COL.Column_Name + ''', ''IsClustered'') IS NULL ' +
            'CREATE INDEX [IX_' + COL.Table_Name + '_' + COL.Column_Name + '] ON [dbo].[' + COL.Table_Name + '] ([' + COL.Column_Name + '])' AS IndexString

FROM INFORMATION_SCHEMA.COLUMNS COL
      JOIN INFORMATION_SCHEMA.TABLES TAB
            ON COL.TABLE_NAME = TAB.TABLE_NAME
WHERE Column_Name LIKE '%ID' 
	AND Column_Name != 'ID' -- exclude primary key field (it has it's own CLUSTERED index)
    AND TAB.TABLE_TYPE = 'BASE TABLE'
    AND TAB.TABLE_NAME != 'sysdiagrams' -- exclude system types
ORDER BY TableName, ColumnName
OPEN DatabaseCursor  

FETCH NEXT FROM DatabaseCursor INTO @TableName, @ColumnName, @Statement
WHILE @@FETCH_STATUS = 0  
BEGIN  
  
   PRINT @TableName + ' - ' + @ColumnName
   --PRINT @Statement
   EXEC (@Statement)  
   SET @Count = @Count + 1
   FETCH NEXT FROM DatabaseCursor INTO @TableName, @ColumnName, @Statement  
END  
CLOSE DatabaseCursor   
DEALLOCATE DatabaseCursor

PRINT ''
PRINT CAST(@Count as VARCHAR) + ' Columns are found to be missing index';
