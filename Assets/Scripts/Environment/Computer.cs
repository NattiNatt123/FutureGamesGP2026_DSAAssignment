using Environment.Tasks;
using UnityEditorInternal;
using UnityEngine;
using System;

namespace Environment {

    [Serializable]
    public class Employee
    {
        public string name;
        public bool EmployeeID;
        public bool roomClearance;


    }

    [Serializable]
     public class EmployeeArray
    {

        public Employee[] employees;

    }

    public class Computer : MonoBehaviour, IInteractable
    {
       
        [SerializeField] TextAsset jsonFile;


        public void OnInteract()
        {
            if(jsonFile == null)
            {
                return;
            }

            Employee[] employees = JsonUtility.FromJson() < EmployeeArray > (jsonFile.text)?.employees;

            if (Employee != null && employees.Length <= 0)
            {
                return;
            }
            foreach(Employee employee in employees)
            {
                Debug.Log("Name: " + employee.name);
                Debug.Log("Employee ID: " + employee.EmployeeID);
                Debug.Log("Engine Room Clearance: " + employee.roomClearance);
            }

        }






    }
}
