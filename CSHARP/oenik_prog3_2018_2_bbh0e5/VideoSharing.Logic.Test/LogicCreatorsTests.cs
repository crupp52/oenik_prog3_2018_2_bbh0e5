using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSharing.Data;
using VideoSharing.Repository;

namespace VideoSharing.Logic.Test
{
    class LogicCreatorsTests
    {
        Mock<IRepository<Creators>> mock;
        CreatorsLogic logic;

        [SetUp]
        public void Setup()
        {
            this.mock = new Mock<IRepository<Creators>>();
            List<Creators> list = new List<Creators>()
            {
                
            };

            this.mock.Setup(x => x.GetAll()).Returns(list.AsQueryable());

            this.logic = new CreatorsLogic(this.mock.Object);
        }
    }
}
