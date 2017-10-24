using System;
using System.IO;
using System.Threading.Tasks;

namespace GeeCoeur
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}
