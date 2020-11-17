using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterCloneAPI.DataSource;
using TwitterCloneAPI.Interfaces;
using TwitterCloneAPI.Models;

namespace TwitterCloneAPI.Misc
{

    public  class LoginCheck
    {

        public LoginCheck()
        {
            //TODO: Make me dependant on Setting to use DynamoDB or Fixed Source
            theSource = new FixedSource();
        }

         IDataSource theSource;


        public clientUser Check(clientLoginModel user)
        {
            var userModel = theSource.GetUser(user.Username, user.Password);
            return userModel;
        }

    }
}
