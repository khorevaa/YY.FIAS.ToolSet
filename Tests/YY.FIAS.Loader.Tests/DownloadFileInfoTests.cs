﻿using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace YY.FIAS.Loader.Tests
{
    public class DownloadFileInfoTests
    {
        #region Private Members

        private readonly string _workDirectory;
        private readonly IFIASLoader _loader;
        private DownloadFileInfo _fileInfo;

        #endregion

        #region Constructor

        public DownloadFileInfoTests()
        {
            _loader = new FIASLoader();
            _workDirectory = Path.Combine(Environment.CurrentDirectory, "TestData");
        }

        #endregion

        #region Public Methods

        [Fact(Skip="Too large data file")]
        public async void SaveFiasCompleteDbfFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasCompleteDbfFileTest.dbf");
            await lastInfo.SaveFiasCompleteDbfFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact(Skip = "Too large data file")]
        public async void SaveFiasCompleteDbfToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasCompleteDbfToDirectoryTest.dbf");
            await lastInfo.SaveFiasCompleteDbfToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        [Fact(Skip = "Too large data file")]
        public async void SaveFiasCompleteXmlFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasCompleteXmlFileTest.dbf");
            await lastInfo.SaveFiasCompleteXmlFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact(Skip = "Too large data file")]
        public async void SaveFiasCompleteXmlToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasCompleteXmlToDirectoryTest.dbf");
            await lastInfo.SaveFiasCompleteXmlToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        [Fact(Skip = "Redudant test")]
        public async void SaveFiasDeltaDbFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasDeltaDbFileTest.dbf");
            await lastInfo.SaveFiasDeltaDbFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact]
        public async void SaveFiasDeltaDbToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasDeltaDbToDirectoryTest.dbf");
            await lastInfo.SaveFiasDeltaDbToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        [Fact(Skip = "Redudant test")]
        public async void SaveFiasDeltaXmlFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasDeltaXmlFileTest.dbf");
            await lastInfo.SaveFiasDeltaXmlFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact]
        public async void SaveFiasDeltaXmlToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveFiasDeltaXmlToDirectoryTest.dbf");
            await lastInfo.SaveFiasDeltaXmlToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        [Fact(Skip = "Redudant test")]
        public async void SaveKladr4ArjFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveKladr4ArjFileTest.dbf");
            await lastInfo.SaveKladr4ArjFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact]
        public async void SaveKladr4ArjToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveKladr4ArjToDirectoryTest.dbf");
            await lastInfo.SaveKladr4ArjToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        [Fact(Skip = "Redudant test")]
        public async void SaveKladr47ZFileTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveKladr47ZFileTest.dbf");
            await lastInfo.SaveKladr47ZFileAsync(pathFiasCompleteDbfFile);
        }
        [Fact]
        public async void SaveKladr47ZToDirectoryTest()
        {
            DownloadFileInfo lastInfo = await GetDownloadFileInfo();

            string pathFiasCompleteDbfFile = Path.Combine(_workDirectory, "SaveKladr47ZToDirectoryTest.dbf");
            await lastInfo.SaveKladr47ZToDirectoryAsync(pathFiasCompleteDbfFile);
        }

        #endregion

        #region Private Methods

        private async Task<DownloadFileInfo> GetDownloadFileInfo()
        {
            return _fileInfo ??= await _loader.GetLastDownloadFileInfo();
        }

        #endregion
    }
}
