﻿using System;
using SportLife.Core.SportLifeRepositories.Interfaces;

namespace SportLife.Core.Interfaces {
    public interface IUnitOfWork : IDisposable {
        IAbonementOrderRepository AbonementOrderRepository { get; }
        IAbonementRepository AbonementRepository { get; }
        IClientRepository ClientRepository { get; }
        ICoachRepository CoachRepository { get; }
        IHallRepository HallRepository { get; }
        IPriceRepository PriceRepository { get; }
        ISheduleRepository SheduleRepository { get; }
        ISportCategoryRepository SportCategoryRepository { get; }
        ISportRepository SportRepository { get; }
        IUserRepository UserRepository { get; }
        IVisitingRepository VisitingRepository { get; }

        void SaveChanges();
    }
}