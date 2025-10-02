using Business.Interfaces;
using Data.Data;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// TODO: Configure basic MVC services

// TODO: Configure database context based on operating system

// TODO: Register data seeding service

// TODO: Register Unit of Work pattern

// TODO: Configure AutoMapper for entity-model mapping

// TODO: Register business layer services

// TODO: Seed initial data

// TODO: Configure development environment features

// TODO: Configure middleware pipeline

app.Run();

// 🚨 CRITICAL: DO NOT DELETE THIS CLASS!
// This partial class is required for integration testing with WebApplicationFactory
// It allows test projects to access the Program class and configure the test host
// Removing this class will break all integration tests in WebApi.Tests project
// This is a .NET 6+ pattern for enabling testing of top-level programs
public partial class Program { }
