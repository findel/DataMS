
using System;
using System.Collections.Generic;
using Nancy;

namespace DataMS
{
	public class MainModule : NancyModule
	{
	    public MainModule() : base("/_DataMS")
	    {
	        // Capture /_DataMS/
	        Get["/"] = parameters => {
	            return "Hello DataMS application!";
	        };
	    }
	}
}