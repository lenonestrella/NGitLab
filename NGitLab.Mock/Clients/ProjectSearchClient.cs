﻿using System;
using NGitLab.Models;

namespace NGitLab.Mock.Clients
{
    internal sealed class ProjectSearchClient : ClientBase, ISearchClient
    {
        private readonly ClientContext _context;
        private readonly int _projectId;

        public ProjectSearchClient(ClientContext context, ProjectId projectId)
            : base(context)
        {
            _context = context;
            _projectId = Server.AllProjects.FindProject(projectId.ValueAsUriParameter()).Id;
        }

        public GitLabCollectionResponse<SearchBlob> GetBlobsAsync(SearchQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
