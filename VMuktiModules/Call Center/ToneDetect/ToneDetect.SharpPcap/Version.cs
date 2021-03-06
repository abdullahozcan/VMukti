<<<<<<< HEAD:VMuktiModules/Call Center/ToneDetect/ToneDetect.SharpPcap/Version.cs
/* VMukti 2.0 -- An Open Source Video Communications Suite
*
* Copyright (C) 2008 - 2009, VMukti Solutions Pvt. Ltd.
*
* Hardik Sanghvi <hardik@vmukti.com>
*
* See http://www.vmukti.com for more information about
* the VMukti project. Please do not directly contact
* any of the maintainers of this project for assistance;
* the project provides a web site, forums and mailing lists      
* for your use.

* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.

* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU General Public License for more details.

* You should have received a copy of the GNU General Public License
* along with this program. If not, see <http://www.gnu.org/licenses/>
 
*/
=======
>>>>>>> b74131bacb80d82c79711cf70fe93af3fb611b40:VMuktiModules/Call Center/ToneDetect/ToneDetect.SharpPcap/Version.cs
using System;

namespace ToneDetect.SharpPcap
{
	/// <summary>
	/// Represent the current version of SharpPcap.
	/// </summary>
	public class Version
	{
		/// <summary>
		/// Returns the current version string of the SharpPcap library
		/// </summary>
		/// <returns>the current version string of the SharpPcap library</returns>
		public static string GetVersionString()
		{
			System.Reflection.Assembly asm
				= System.Reflection.Assembly.GetAssembly(typeof(Version));
			return asm.GetName().Version.ToString();
		}
	}
}
