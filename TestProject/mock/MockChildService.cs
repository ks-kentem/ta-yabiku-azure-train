using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.models;

namespace TestProject.mock
{
    class MockChildService : IChildService
    {
        public string GetGreeting()
        {
            return "モックです。";
        }
    }
}
