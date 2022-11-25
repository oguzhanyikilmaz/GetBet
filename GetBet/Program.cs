using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;

namespace GetBet
{
    class Program
    {
        static  void Main(string[] args)
        {

            Business business = new Business();
            business.GetBulten();

        }
    }
}
