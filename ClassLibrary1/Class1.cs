using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Main()
        {
            var conn = "replaceWithValidBlobConnectionString";
            var client = GetBlobClient(conn);
        }

        private static BlobServiceClient GetBlobClient(string connectionString)
        {
            // this line throws the error!!!
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            return blobServiceClient;
        }
    }
}
