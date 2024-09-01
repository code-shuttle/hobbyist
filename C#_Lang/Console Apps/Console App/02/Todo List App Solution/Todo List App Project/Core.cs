using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List_App_Project
{
    class Todo(string title, List<string> items)
    {
        public TodoId Id { get; set; } = TodoId.NewTodoId();
        public TodoDate Date { get; set; } = TodoDate.NewTodoDate();
        public string Title { get; set; } = title;
        public List<string> Items { get; set; } = items;
    }

    readonly record struct TodoId(Guid Value)
    {
        public static TodoId Empty => new(Guid.Empty);
        public static TodoId NewTodoId() => new(Guid.NewGuid());
    }

    readonly record struct TodoDate(DateTime Value)
    {
        public static TodoDate NewTodoDate() => new(DateTime.Now);
    }
}
