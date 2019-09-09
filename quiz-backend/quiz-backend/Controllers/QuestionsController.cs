using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quiz_backend.Controllers
{
    [Route("api/Questions")]
    [Produces("application/json")]
    public class QuestionsController : ControllerBase
    {
    readonly QuizContext context;
    public QuestionsController(QuizContext context)
    {
      this.context = context;
    }

    [HttpPost]
    public void Post([FromBody] Models.Question question)
    {
      context.Questions.Add(new Models.Question() { Text = "Text" });
      context.SaveChanges();
    }

    [HttpGet]
    public ActionResult<IEnumerable<Models.Question>> Get()
    {
      return new Models.Question[] { new Models.Question() {
      Text="placeholder"},
      new Models.Question() {
      Text="text"},
      new Models.Question() {
      Text="three"}};
    }
  }
}
