﻿using System.Collections.Generic;
using AxosoftAPI.NET.Core.Interfaces;
using AxosoftAPI.NET.Models;

namespace AxosoftAPI.NET.Interfaces
{
	public interface IPicklists
	{
		Result<IEnumerable<PicklistItem>> Get(string type, IDictionary<string, object> parameters = null);

		Result<PicklistItem> Get(string type, int id, IDictionary<string, object> parameters = null);

		IPicklistResource<Priority> Priority { get; }

		IPicklistResource<Severity> Severity { get; }

		IPicklistResource<Status> Status { get; }
	}
}
