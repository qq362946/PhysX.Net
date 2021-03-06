﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhysX.Test
{
	[TestClass]
	public class DistanceJointTest : Test
	{
		[TestMethod]
		public void CreateAndDisposeDistanceJoint()
		{
			using (var core = CreatePhysicsAndScene())
			{
				var box = CreateBoxActor(core.Scene, 5, 5, 5);

				var lf0 = Matrix4x4.CreateTranslation(1, 2, 3);
				var lf1 = Matrix4x4.CreateTranslation(3, 2, 1);

				using (var distance = core.Scene.CreateJoint<DistanceJoint>(box, lf0, null, lf1))
				{

				}
			}
		}
	}
}