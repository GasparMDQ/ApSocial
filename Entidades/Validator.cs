using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApSocial.Entidades
{
    public class Validator
    {
        string message;
        bool valid;

        public Validator()
        {
            this.valid = true;
            this.Message = "";
        }

        public string Message
        {
            get { return "Revise los siguientes datos:\n" + message; }
            set { message = value; }
        }

        public bool Valid
        {
            get { return valid; }
        }

        public void addError(string error)
        {
            this.Message = this.message + error + "\n";
            this.valid = false;
        }

    }
}
