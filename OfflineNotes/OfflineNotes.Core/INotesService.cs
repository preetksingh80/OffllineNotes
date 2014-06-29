using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineNotes.Core
{
    public interface INotesService
    {
        void Save(int id, string name, string note);
        
    }
}
