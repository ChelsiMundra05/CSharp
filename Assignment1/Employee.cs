using System;

namespace Assignment1
{
    public delegate void MethodCallDelegate(object sender, EventArgs args, string functionName);
    class Employee
    {
        private int id;
        private string name;
        private string departmentName;
        public event MethodCallDelegate MethodCall;

        public Employee(int id, string name, string departmentName)
        {
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
        }

        public int GetId()
        { 
            if (MethodCall!= null)
            {
                MethodCall(this, new EventArgs(), "GetId");
            }
            return id;
        }
        public string GetName()
        {
            if (MethodCall!= null)
            {
                MethodCall(this, new EventArgs(), "GetName");
            }
            return name;
        }
        public string GetDepartmentName()
        {
            if (MethodCall!= null)
            {
                MethodCall(this, new EventArgs(), "GetDepartmentName");
            }
            return departmentName;
        }

        public void modify(int id)
        {
            this.id=id;
        }
        public void modify(string name)
        {
            this.name=name;
        }
        public void modify(int id, string departmentName)
        {
            if(this.id==id)
            {
                this.departmentName=departmentName;
            }
        }
    }
}