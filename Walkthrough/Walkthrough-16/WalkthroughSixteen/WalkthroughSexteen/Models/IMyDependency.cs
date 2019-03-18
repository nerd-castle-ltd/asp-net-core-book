using System.Threading.Tasks;

namespace WalkthroughSixteen.Models
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
