using Mini_Uber;
using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class SetValidation
    {
        IValidation CheckFName = new ValidFName();
        IValidation CheckLName = new ValidLname();
        IValidation UserNameexist = new UserNameExist();
        IValidation CheckPhone = new ValidPhone();

        public SetValidation()
        {
            CheckFName.setNext(CheckLName);
            CheckLName.setNext(UserNameexist);
            UserNameexist.setNext(CheckPhone);
        }

        public void sendValidation(User PP )
        {
            CheckFName.valid(PP);
        }
    }

}
