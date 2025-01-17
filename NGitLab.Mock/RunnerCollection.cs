﻿using System;
using System.Linq;

namespace NGitLab.Mock
{
    public sealed class RunnerCollection : Collection<Runner>
    {
        public RunnerCollection(Project parent)
            : base(parent)
        {
        }

        public override void Add(Runner item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            if (Server is null)
                throw new ObjectNotAttachedException();

            if (item.Id == default)
            {
                item.Id = Server.GetNewRunnerId();
            }

            item.Token ??= Server.GetNewRunnerToken();

            base.Add(item);
        }

        public bool Remove(int id)
        {
            var r = this.SingleOrDefault(r => r.Id == id);
            return Remove(r);
        }
    }
}
