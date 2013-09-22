RedPsnWrapper
=============

Wrapper for xxredxiiixx.com PlayStation Network API.

Learn more about the API at http://xxredxiiixx.com/psnapi/ .

See also https://github.com/JamesSkemp/PsnTrophies about our community-driven attempt to provide PlayStation Network trophy data to all.

Usage
====

The API is still in progress, but right now you can pull basic information about a user, as well as general information about individual games.

LINQPad example below:

	var api = new RedPsnWrapper.PsnApi();
	
	api.GetProfile("strivinglife").Dump();
	// A delay between requests is required, and the wrapper has an adjustable one baked in.
	Thread.Sleep(api.RequestDelay);
	api.GetGame("NPWR03852_00").Dump();
	
	api.Dump();
