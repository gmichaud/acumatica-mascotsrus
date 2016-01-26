using System;
using Core.Login;
using Core.TestExecution;
using Core.Log;
using Acumatica.RentalPro.Tests;

namespace Acumatica.RentalPro
{
    public class Test : Check
    {
        public override void Execute()
        {
            PxLogin.LogIn("admin", "admin");
            var toolsForm = new RentalItemManagement();
            toolsForm.OpenScreen();

            toolsForm.Insert();
            toolsForm.Summary.RentalItemCD.Type("ABC");
            toolsForm.Summary.Description.Type("My new costume");
            toolsForm.Summary.SerialNumber.Type("XYZ"); //System should complain that serial number doesn't start with MRU-.

            try
            {
                toolsForm.Save();
                Log.Error("Rental item should not have saved, serial number is invalid");
            }
            catch(Exception e)
            {
                Log.Information(e.Message);
            }

            toolsForm.Summary.SerialNumber.Type("MRU-1234");
            toolsForm.Save();
            Log.Information("Test completed!");
        }
    }
}