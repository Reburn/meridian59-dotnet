﻿/*
 Copyright (c) 2012-2013 Clint Banzhaf
 This file is part of "Meridian59 .NET".

 "Meridian59 .NET" is free software: 
 You can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, 
 either version 3 of the License, or (at your option) any later version.

 "Meridian59 .NET" is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 See the GNU General Public License for more details.

 You should have received a copy of the GNU General Public License along with "Meridian59 .NET".
 If not, see http://www.gnu.org/licenses/.
*/

using System;
using Meridian59.Protocol.Enums;

namespace Meridian59.Protocol.GameMessages
{
    /// <summary>
    /// Sent by the server to the client as positive response to ReqGame.
    /// This is the last message of protocol mode 'login'.
    /// After this any message will be of type protocol mode 'game'.
    /// </summary>
    [Serializable]
    public class GameStateMessage : LoginModeMessage
    {        
        public GameStateMessage()
            : base(MessageTypeLoginMode.Game) { }

        public GameStateMessage(byte[] Buffer, int StartIndex = 0)
            : base(Buffer, StartIndex = 0) { }
    }
}
