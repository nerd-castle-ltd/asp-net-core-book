using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkthroughNine.Models;
using WalkthroughNine.RepositoryInterfaces;

namespace WalkthroughNine.Repository
{
    public class ToDoItemRepository :IToDoItemRepository
    {
        public List<ToDoItem> List()
        {
            return new List<ToDoItem>
            {
                new ToDoItem(){Id = 1,Name = "Task 1",Priority = 1,IsDone = true},
                new ToDoItem(){Id = 2,Name = "Task 2",Priority = 2,IsDone = true},
                new ToDoItem(){Id = 3,Name = "Task 3",Priority = 1,IsDone = false},
                new ToDoItem(){Id = 4,Name = "Task 4",Priority = 3,IsDone = true},
                new ToDoItem(){Id = 5,Name = "Task 5",Priority = 1,IsDone = false},
                new ToDoItem(){Id = 6,Name = "Task 6",Priority = 2,IsDone = true},
            };
        }
    }
}
