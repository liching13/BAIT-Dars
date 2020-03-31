using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace ArdalisRating
{
    class FileSource
    {
        private string _fileName;
        private string _fileContent;
        public FileSource(string fileName)
        {
            this._fileName = fileName;
        }
        private void GetContent()
        {
            _fileContent = File.ReadAllText(_fileName);
        }

        public Policy DeserializeFile()
        {
            GetContent();
            return JsonConvert.DeserializeObject<Policy>(_fileContent, new StringEnumConverter());
        }
    }
}
