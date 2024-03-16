using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using PVAO.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InfrastructureTests.Data
{
    [TestClass]
    public class SettingsRepositoryTests
    {
        private ISettingsRepository _repository;
        private PVAOContext _context;
        private DbContextOptionsBuilder<PVAOContext> _builder;

        [TestInitialize]
        public void Initialize()
        {
            _builder = new DbContextOptionsBuilder<PVAOContext>();
            _builder.UseInMemoryDatabase("TestDB" + Guid.NewGuid().ToString());

            _context = new PVAOContext(_builder.Options);
            _repository = new SettingsRepository(_context);
        }

        [TestMethod]
        public void CreateRepository()
        {
            Assert.IsNotNull(_repository);
            Assert.IsInstanceOfType(_repository, typeof(ISettingsRepository));
        }

        [TestMethod]
        public void Get()
        {
            var settings = CreateSettings();

            var result = _repository.Add(settings);

            Assert.IsNotNull(settings);
            Assert.IsNotNull(result);
        }

        private Settings CreateSettings()
        {
            var entity = new Settings()
            {
                Id = 1,
                FromEmail = "donotreply-pvao@gmail.com",
                FromName = "Philippine Veterans Affairs Office (PVAO)",
                ServerName = "smtp.gmail.com",
                SMTPPort = 587,
                Username = "donotreply-pvao@gmail.com",
                Password = "$P2==YQBY4",
                EnableSSL = true,
                MaxSignOnAttempts = 4,
                ExpiresIn = 45,
                MinPasswordLength = 10,
                MinSpecialCharacters = 2,
                EnforcePasswordHistory = 2,
                CreatedBy = 1,
                DateCreated = DateTime.Parse("2/21/2021 11:30:23 AM"),
                UpdatedBy = 1,
                DateUpdated = DateTime.Parse("2/21/2021 12:34:00 PM")
            };

            return entity;
        }
    }
}
