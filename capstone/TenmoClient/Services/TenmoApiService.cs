﻿using RestSharp;
using System.Collections.Generic;
using TenmoClient.Models;
using TenmoServer.Models;

namespace TenmoClient.Services
{
    public class TenmoApiService : AuthenticatedApiService
    {
        public readonly string ApiUrl;

        public TenmoApiService(string apiUrl) : base(apiUrl) { }

        // Add methods to call api here...
        public Account GetAccount()
        {
            RestRequest request = new RestRequest("account");

            IRestResponse<Account> response = client.Get<Account>(request);

            CheckForError(response);

            return response.Data;
        }
        public Account GetAccountByUserId(int userId)
        {
            RestRequest request = new RestRequest("account");

            IRestResponse<Account> response = client.Get<Account>(request);

            CheckForError(response);

            return response.Data;
        }
        public List<ApiUser> GetUsers()
        {
            RestRequest request = new RestRequest("user");

            IRestResponse<List<ApiUser>> response = client.Get<List<ApiUser>>(request);

            CheckForError(response);

            return response.Data;
        }
        public Transfer AddTransfer(TransferRequest transferRequest)
        {
            RestRequest request = new RestRequest("account");

            request.AddJsonBody(transferRequest);

            IRestResponse<Transfer> response = client.Post<Transfer>(request);

            CheckForError(response);

            return response.Data;
        }
        public List<Transfer> GetAllTransfer()
        {
            RestRequest request = new RestRequest("transfer");

            IRestResponse<List<Transfer>> response = client.Get<List<Transfer>>(request);

            CheckForError(response);

            return response.Data;
        }

    }
}
