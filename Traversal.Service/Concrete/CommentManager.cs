using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Service.Abstract;

namespace Traversal.Service.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void TAdd(Comment t)
        {
            _commentRepository.Add(t);
        }

        public void TDelete(Comment t)
        {
            _commentRepository.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentRepository.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _commentRepository.GetList();
        }

        public void TUpdate(Comment t)
        {
            _commentRepository.Update(t);
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentRepository.GetListByFilter(x => x.DestinationId == id);
        }

        public List<Comment> TGetListCommnetWithDestination()
        {
            return _commentRepository.GetListCommentWithDestination();
        }
    }
}
