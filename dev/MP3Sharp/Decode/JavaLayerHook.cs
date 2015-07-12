// /***************************************************************************
//  * JavaLayerHook.cs
//  * Copyright (c) 2015 the authors.
//  * 
//  * All rights reserved. This program and the accompanying materials
//  * are made available under the terms of the GNU Lesser General Public License
//  * (LGPL) version 3 which accompanies this distribution, and is available at
//  * https://www.gnu.org/licenses/lgpl-3.0.en.html
//  *
//  * This library is distributed in the hope that it will be useful,
//  * but WITHOUT ANY WARRANTY; without even the implied warranty of
//  * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  * Lesser General Public License for more details.
//  *
//  ***************************************************************************/

namespace MP3Sharp.Decode
{
    /// <summary>
    ///     The <code>JavaLayerHooks</code> class allows developers to change
    ///     the way the JavaLayer library uses Resources.
    /// </summary>
    internal interface JavaLayerHook
    {
        /// <summary>
        ///     Retrieves the named resource. This allows resources to be
        ///     obtained without specifying how they are retrieved.
        /// </summary>
        System.IO.Stream getResourceAsStream(string name);
    }
}