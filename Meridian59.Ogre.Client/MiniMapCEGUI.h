/*
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

#pragma once

#pragma managed(push, off)
#include "OgreTexture.h"
#include "CEGUI/String.h"
#pragma managed(pop)

namespace Meridian59 { namespace Ogre 
{
	using namespace ::Ogre;
	using namespace Meridian59::Drawing2D;
	using namespace Meridian59::Data::Models;
	using namespace Meridian59::Files::ROO;
	using namespace System::Drawing;
	using namespace System::Drawing::Drawing2D;
	using namespace System::Drawing::Imaging;

	/// <summary>
    /// Implements MiniMap class from core library
    /// </summary>
	public ref class MiniMapCEGUI : MiniMap<::System::Drawing::Bitmap^>
	{
	protected:
		void* texbuf;
		::Ogre::Texture* texture;
		
		::System::Drawing::Color backgroundColor;
		::System::Drawing::Graphics^ g;
        ::System::Drawing::Pen^ wallPen;
        ::System::Drawing::SolidBrush^ purpleBrush;
        ::System::Drawing::SolidBrush^ redBrush;
        ::System::Drawing::SolidBrush^ blueBrush;
        ::System::Drawing::SolidBrush^ greenBrush;
        ::System::Drawing::SolidBrush^ orangeBrush;

		void RecreateImageAndGraphics();

	public:
		::CEGUI::String* TextureName;

		/// <summary>
        /// Constructor
        /// </summary>
		MiniMapCEGUI(::Meridian59::Data::DataController^ Data, int Width, int Height);

		virtual void SetDimension(int Width, int Height) override;
		virtual void PrepareDraw() override;
		virtual void DrawWall(RooWall^ Wall, CLRReal x1, CLRReal y1, CLRReal x2, CLRReal y2) override;
		virtual void DrawObject(RoomObject^ RoomObject, CLRReal x, CLRReal y, CLRReal width, CLRReal height) override;
		virtual void FinishDraw() override;
	};

};};
