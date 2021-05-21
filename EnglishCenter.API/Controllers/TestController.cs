﻿using EnglisCenter.Accessor.Entities;
using EnglishCenter.Business.Interfaces;
using EnglishCenter.Common.Models.Result;
using EnglishCenter.Common.Models.Test;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglisCenter.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpPost]
        public async Task<ActionResult<Test>> PostTest(TestRequest createRequestTest)
        {
            var test =await _testService.Add(createRequestTest);
            return Ok(test);
        }

        // Get test by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<TestResponse>> GetTestDetail(int id)
        {
            var test = await _testService.GetTestDetail(id);
            return Ok(test);
        }

        // get all test
        [HttpGet("listtest")]
        public async Task<ActionResult<IEnumerable<TestResponse>>> GetTests()
        {
            var tests = await _testService.GetTests();
            return Ok(tests);
        }

        [HttpGet("listByCourse/{courseId}")]
        public async Task<ActionResult<IEnumerable<TestResponse>>> GetTestsByCourse([FromRoute]int courseId)
        {
            var tests = await _testService.GetTestsByCourse(courseId);
            return Ok(tests);
        }

        // test new 
        [HttpGet("new")]
        public async Task<ActionResult<IEnumerable<TestResponse>>> GetTestsUpComming()
        {
            var tests = await _testService.GetTestsUpComming();
            return Ok(tests);
        }

        //
        [HttpGet("new/courseid")]
        public async Task<ActionResult<IEnumerable<TestResponse>>> GetTestByCousrse(int courseId)
        {
            var tests = await _testService.GetTestByCousrse(courseId);
            return Ok(tests);
        }

        //list test
        [HttpGet("old")]
        public async Task<ActionResult<IEnumerable<Test>>> GetTestsFinished()
        {
            var tests = await _testService.GetTestsFinished();
            return Ok(tests);
        }


        [HttpGet("old/courseid")]
        public async Task<ActionResult<IEnumerable<Test>>> GetTestByCousrseFinished(int courseId)
        {
            var tests = await _testService.GetTestByCousrseFinished(courseId);
            return Ok(tests);
        }


        [HttpGet("overdue")]
        public async Task<ActionResult<IEnumerable<Test>>> GetTestCompleted(int accountid)
        {
            var tests = await _testService.GetTestCompleted(accountid);
            return Ok(tests);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Test>> DeleteTest([FromRoute] int id)
        {
            var test = await _testService.DeleteTest(id);
            return Ok(test);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Test>> UpdateTest([FromRoute] int id,TestEditRequest createRequestTest)
        {
            var test = await _testService.UpdateTest(id, createRequestTest);
            return Ok(test);
        }

        //submit the test
        [HttpPost("submit")]
        public async  Task<IActionResult> SubmitTest(ResultRequest submitResultTest)
        {
            await  _testService.SubmitTest(submitResultTest);
            return Ok();
        }
    }
}