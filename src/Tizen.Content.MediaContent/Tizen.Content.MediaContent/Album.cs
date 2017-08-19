/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Content.MediaContent
{
    /// <summary>
    /// Represents a logical collection grouping of related media info.
    /// </summary>
    /// <seealso cref="AlbumCommand"/>
    public class Album
    {
        internal Album(IntPtr handle)
        {
            Id = InteropHelper.GetValue<int>(handle, Interop.Album.GetId);

            Artist = InteropHelper.GetString(handle, Interop.Album.GetArtist);
            AlbumArtPath = InteropHelper.GetString(handle, Interop.Album.GetAlbumArt);
            Name = InteropHelper.GetString(handle, Interop.Album.GetName);
        }

        internal static Album FromHandle(IntPtr handle) => new Album(handle);

        /// <summary>
        /// Get the id of the album.
        /// </summary>
        /// <value>The unique id of the album.</value>
        public int Id { get; }

        /// <summary>
        /// Gets the artist name of the album.
        /// </summary>
        /// <value>The artist name.</value>
        public string Artist { get; }

        /// <summary>
        /// Gets the path to the album art.
        /// </summary>
        /// <value>The path to the album art.</value>
        public string AlbumArtPath { get; }

        /// <summary>
        /// Gets the name of the album.
        /// </summary>
        /// <value>The album name.</value>
        public string Name { get; }

        /// <summary>
        /// Returns a string representation of the album.
        /// </summary>
        /// <returns>A string representation of the current album.</returns>
        public override string ToString() =>
            $"Id={Id}, Name={Name}, Artist={Artist}, AlbumArtPath={AlbumArtPath}";
    }
}