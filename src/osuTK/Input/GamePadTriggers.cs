﻿//
// GamePadTriggers.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//


using System;

namespace osuTK.Input
{
    /// <summary>
    /// Describes the state of a <see cref="GamePad"/> trigger buttons.
    /// </summary>
    public struct GamePadTriggers : IEquatable<GamePadTriggers>
    {
        private const float ConversionFactor = 1.0f / byte.MaxValue;
        private byte left;
        private byte right;

        internal GamePadTriggers(byte left, byte right)
        {
            this.left = left;
            this.right = right;
        }

        /// <summary>
        /// Gets the offset of the left trigger button, between 0.0 and 1.0.
        /// </summary>
        public float Left
        {
            get { return left * ConversionFactor; }
        }

        /// <summary>
        /// Gets the offset of the left trigger button, between 0.0 and 1.0.
        /// </summary>
        public float Right
        {
            get { return right * ConversionFactor; }
        }

        /// <param name="left">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
        {
            return left.Equals(right);
        }

        /// <param name="left">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        /// <param name="right">A <see cref="GamePadTriggers"/> instance to test for equality.</param>
        public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="osuTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="osuTK.Input.GamePadTriggers"/>.</returns>
        public override string ToString()
        {
            return String.Format(
                "({0:f2}; {1:f2})",
                Left, Right);
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="osuTK.Input.GamePadTriggers"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return
                left.GetHashCode() ^ right.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to the current <see cref="osuTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with the current <see cref="osuTK.Input.GamePadTriggers"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to the current
        /// <see cref="osuTK.Input.GamePadTriggers"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return
                obj is GamePadTriggers &&
                Equals((GamePadTriggers)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="osuTK.Input.GamePadTriggers"/> is equal to the current <see cref="osuTK.Input.GamePadTriggers"/>.
        /// </summary>
        /// <param name="other">The <see cref="osuTK.Input.GamePadTriggers"/> to compare with the current <see cref="osuTK.Input.GamePadTriggers"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="osuTK.Input.GamePadTriggers"/> is equal to the current
        /// <see cref="osuTK.Input.GamePadTriggers"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(GamePadTriggers other)
        {
            return
                left == other.left &&
                right == other.right;
        }
    }
}
