using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkthroughNine.Models;

namespace WalkthroughNine.RepositoryInterfaces
{
    public interface IToDoItemRepository
    {
        List<ToDoItem> List();
    }
}
