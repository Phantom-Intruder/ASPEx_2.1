using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEx_2.Helpers
{
    public class Constants
    {
        //Controllers 
        public const string         CONTROLLER_HOME                 = "Home";
        public const string         CONTROLLER_ADMIN                = "AdminView";
        public const string         CONTROLLER_PRODUCT_LIST         = "List";
		public const string			CONTROLLER_PRODUCT				= "Product";
		public const string         CONTROLLER_CART                 = "ShoppingCart";
        public const string         CONTROLLER_INDEX                = "Index";

        //Models
        public const string         MODEL_CATEGORY                  = "category";
        public const string         MODEL_PRODUCT                   = "product";

        //Logins
        public const string         ENTER_LOGIN_MESSAGE             = "Enter your login details below";
        public const string         CURRENT_USER                    = "CurrentUser";
        public const string         REGISTRATION_MESSAGE            = "Enter registration details below";
        public const string         WRONG_USERNAME                  = "Wrong username/password";
        public const string         EMAIL_IN_USE                    = "The e-mail is already in use";

        //File
        public const string         FILE_NAME                       = "attachment; filename=data.xls";
        public const string         CONTENT_DISPOSITION             = "content-disposition";
        public const string         APPLICATION_VND                 = "application/vnd.ms-excel";

        //Other
        public const string         CATEGORY_COLUMN                 = "Category";
        public const string         UNITS_SOLD_COLUMN               = "Units sold";
        public const string         DATA_TYPE_STRING                = "System.String";
        public const string         CATEGORY_TYPE_NONE              = "none";
        public const string         SESSION_SINGLETON_NAME          = "Singleton_502E69E5-668B-E011-951F-00155DF26207";


		#region  Default Values 

		internal const int			DEFAULT_VALUE_INT				= -1;

		#endregion

		#region Session Name

		internal const string		SESSION_NAME_CATEGORY			= "_AdminCategory";
		
		#endregion

	}
}