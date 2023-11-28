namespace AdrianBooks.Data;
using AdrianBooks.Models;
using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext :DbContext
{

    public ApplicationDbContext(DbContextOptions<Application> options):base(options){

    }

    public DbSet<BooksEntity> Books{get;} 

}