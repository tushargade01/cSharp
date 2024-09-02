using System;
namespace Accembly1{
    class College{
        protected string collegeName = "DPMK";
    }
    class scienceDepartment:College{
        public void departmentName(){
            Console.WriteLine("it is science department of "+collegeName);
        }
    }
    class ArtDepartment:College{
        public void departmentName(){
            Console.WriteLine("it is Art department of "+collegeName);
        }
    }

    class Program{
        public static void Main(String[] args){
            ArtDepartment ad = new ArtDepartment();
            ad.departmentName();

            scienceDepartment sd = new scienceDepartment();
            sd.departmentName();
        }
    }
}