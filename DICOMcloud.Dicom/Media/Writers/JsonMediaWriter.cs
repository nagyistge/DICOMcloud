﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fo = Dicom;
using DICOMcloud.Core.Storage;

namespace DICOMcloud.Dicom.Media
{
    public class JsonMediaWriter : DicomMediaWriter
    {
        public JsonMediaWriter ( IMediaStorageService mediaStorage ) : base ( mediaStorage, new JsonDicomConverter ( ), MimeMediaTypes.Json )
        {}
    }
}
