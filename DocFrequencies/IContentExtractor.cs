using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFrequencies
{
    using System.IO;

    /// <summary>
    ///     Экстрактор контента
    /// </summary>
    public interface IContentExtractor
    {
        /// <summary>
        ///     Извлечение текста из потока файла
        /// </summary>
        /// <param name="stream">открытый поток файла</param>
        /// <returns>текст, который удалось извлечь либо null</returns>
        string Extract(Stream stream);
    }
}
