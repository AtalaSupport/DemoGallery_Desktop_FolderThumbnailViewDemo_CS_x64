# FolderThumbnailViewDemo (AKA FolderThumbs)

## About the Demo
This is a demo that shows how to use our FolderThumbnailView windows formc control

The original demo was named "FolderThumbs"

This is the C# version

## About FolderThumbnailView
The FolderThumbnailView is a control (derived from the ThumbnailView class) that 
will display images in a directory as thumbnails, and monitor/update as it detects
changes .This is useful for displaying the contents of a directory on disk.  The 
demo shows how the thumbnails can be resized, reordered, and used to show a larger 
version of the image in the viewer. A background image may also be added to the 
thumbnails, along with many other features available in the thumbnail control.

This control is great for incorporating into your own custom Digital Asset 
Management (DAM) or similar application.

You can use it in combination with our other controls, for instance, use it 
to provide the top level thumbs for the documents in a directlry and wire it up
so that clicking on a given thumb opens the full doucment in our DocuemtnViewer 
or DocumentAnnotationViewer controls


## Prerequisites
This demo assumes you have the Atalasoft DotImage SDK installed and licensed for 
DotImage Document Imaging. Optionally, you may wish to have a licnse for our 
PdfReader add-on if you would like for this demo to be able to read images from 
PDF files.

You may also request a 30 day evaluation when installing / activating.

[Download DotImage](https://www.atalasoft.com/BeginDownload/DotImageDownloadPage)


## Cloning
We recommend the following to ensure you clone with the required submodule

Example: git for windows
```bash
git clone https://github.com/AtalaSupport/DemoGallery_Desktop_FolderThumbnailViewDemo_CS_x64.git FolderThumbnailViewDemo
cd FolderThumbnailViewDemo
git submodule init
git pull
```

## Last Update
2025-11-13 - TD
