﻿using AutoMapper;
using SportLife.Core.Database;
using SportLife.Website.Areas.AdminOffice.Models;

namespace SportLife.Website {
    public class MappingConfig {
        public static void RegisterMappings () {
            Mapper.CreateMap<Client, ClientViewModel>()
                .ForMember(vm => vm.ID, option => option.MapFrom(client => client.ClientId))
                .ForMember(vm => vm.FirstName, option => option.MapFrom(client => client.User.UserFirstName))
                .ForMember(vm => vm.Surname, option => option.MapFrom(client => client.User.UserSurname))
                .ForMember(vm => vm.Email, option => option.MapFrom(client => client.User.Email))
                .ForMember(vm => vm.PhoneNumber, option => option.MapFrom(client => client.User.PhoneNumber))
                .ForMember(vm => vm.BirthDate, option => option.MapFrom(client => client.BirthDate.Value))
                .ForMember(vm => vm.IsActive, option => option.MapFrom(client => client.Abonement.Count > 0))
                .ReverseMap().ForSourceMember(viewModel => viewModel.IsActive, option => option.Ignore());

            Mapper.CreateMap<Client, ClientFullViewModel>()
                .ForMember(vm => vm.ID, option => option.MapFrom(client => client.ClientId))
                .ForMember(vm => vm.FirstName, option => option.MapFrom(client => client.User.UserFirstName))
                .ForMember(vm => vm.Surname, option => option.MapFrom(client => client.User.UserSurname))
                .ForMember(vm => vm.Email, option => option.MapFrom(client => client.User.Email))
                .ForMember(vm => vm.PhoneNumber, option => option.MapFrom(client => client.User.PhoneNumber))
                .ForMember(vm => vm.BirthDate, option => option.MapFrom(client => client.BirthDate.Value))
                .ForMember(vm => vm.IsActive, option => option.MapFrom(client => client.Abonement.Count > 0))
                .ReverseMap().ForSourceMember(viewModel => viewModel.IsActive, option => option.Ignore());

            Mapper.CreateMap<Coach, CoachViewModel>()
                .ForMember(vm => vm.ID, option => option.MapFrom(coach => coach.CoachId))
                .ForMember(vm => vm.FirstName, option => option.MapFrom(coach => coach.User.UserFirstName))
                .ForMember(vm => vm.Surname, option => option.MapFrom(coach => coach.User.UserSurname))
                .ForMember(vm => vm.Email, option => option.MapFrom(coach => coach.User.Email))
                .ForMember(vm => vm.PhoneNumber, option => option.MapFrom(coach => coach.User.PhoneNumber))
                .ForMember(vm => vm.IsActive, option => option.MapFrom(coach => coach.SportGroup.Count > 0))
                .ReverseMap().ForSourceMember(viewModel => viewModel.IsActive, option => option.Ignore());

            Mapper.CreateMap<Coach, CoachFullViewModel>()
                .ForMember(vm => vm.ID, option => option.MapFrom(coach => coach.CoachId))
                .ForMember(vm => vm.FirstName, option => option.MapFrom(coach => coach.User.UserFirstName))
                .ForMember(vm => vm.Surname, option => option.MapFrom(coach => coach.User.UserSurname))
                .ForMember(vm => vm.Email, option => option.MapFrom(coach => coach.User.Email))
                .ForMember(vm => vm.PhoneNumber, option => option.MapFrom(coach => coach.User.PhoneNumber))
                .ForMember(vm => vm.IsActive, option => option.MapFrom(coach => coach.SportGroup.Count > 0))
                .ReverseMap().ForSourceMember(viewModel => viewModel.IsActive, option => option.Ignore());
        }
    }
}