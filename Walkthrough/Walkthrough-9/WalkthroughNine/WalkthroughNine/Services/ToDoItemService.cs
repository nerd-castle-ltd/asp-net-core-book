using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkthroughNine.Models;
using WalkthroughNine.RepositoryInterfaces;
using WalkthroughNine.ServiceInterfaces;

namespace WalkthroughNine.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        public ToDoItemService(IToDoItemRepository toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }

        public List<ToDoItem> List()
        {
            return _toDoItemRepository.List();
        }

        public int GetCount()
        {
            return _toDoItemRepository.List().Count();
        }

        public int GetCompletedCount()
        {
            return _toDoItemRepository.List().Count(x => x.IsDone);
        }

        public double GetAveragePriority()
        {
            if (_toDoItemRepository.List().Count() == 0)
            {
                return 0.0;
            }

            return _toDoItemRepository.List().Average(x => x.Priority);
        }
    }
}
