using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Task
    {
        private string name;
        private string description;
        private DateTime dueDate;
        private bool isCompleted;

        public Task(string name, string description, DateTime dueDate)
        {
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
            this.isCompleted = false;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public DateTime GetDueDate()
        {
            return this.dueDate;
        }

        public void SetDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }

        public bool IsCompleted()
        {
            return this.isCompleted;
        }

        public void MarkAsCompleted()
        {
            this.isCompleted = true;
        }
    }

}
