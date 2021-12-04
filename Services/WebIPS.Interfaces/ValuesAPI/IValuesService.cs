using System;
using System.Collections.Generic;
using System.Net;

namespace WebIPS.Interfaces.ValuesAPI
{
    public interface IValuesService
    {
        IEnumerable<string> Get();

        string Get(int id);

        Uri Post(string value);

        HttpStatusCode Put(int id, string value);

        bool Delete(int id);
    }
}
