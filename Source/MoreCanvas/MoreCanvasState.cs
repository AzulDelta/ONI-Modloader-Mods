﻿using System.Collections.Generic;
using ONI_Common.Json;

namespace MoreCanvas
{
	public class MoreCanvasState
	{
		public bool Enabled { get; set; } = true;

		public int Parameter { get; set; } = 512;


		public static BaseStateManager<MoreCanvasState> StateManager
			= new BaseStateManager<MoreCanvasState>("MoreCanvas");
	}
}