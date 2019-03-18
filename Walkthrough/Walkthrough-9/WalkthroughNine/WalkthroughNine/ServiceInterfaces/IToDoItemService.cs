using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkthroughNine.Models;

namespace WalkthroughNine.ServiceInterfaces
{
    public interface IToDoItemService
    {
        List<ToDoItem> List();
        int GetCount();
        int GetCompletedCount();
        double GetAveragePriority();
    }
}
