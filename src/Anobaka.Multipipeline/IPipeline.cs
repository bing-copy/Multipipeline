﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Anobaka.Multipipeline
{
	public interface IPipeline
	{
		string Name { get; set; }
		Task<bool> ResolveAsync(HttpContext ctx);
		Task ConfigurePipeline(IApplicationBuilder app);
	}
}