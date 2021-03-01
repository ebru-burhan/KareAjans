using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.DataAccess.Concretes
{
    public class CommentRepository : BaseRepository<Comment> , ICommentRepository
    {
        //interfacelere de DI için ihtiyaç var
        //data çekmek için herbirinn reposu ama map tablo için service gerek yok hesap kitap yapmıcaz
        //DI için baserepo istiyo
        public CommentRepository(DbContext _context) : base(_context)
        {
        }
    }
}
