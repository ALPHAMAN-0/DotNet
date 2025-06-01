using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseSelector.Models;
using CourseSelector.Services;
using Microsoft.Extensions.Logging;

namespace CourseSelector.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly CourseService _courseService;

    public IndexModel(ILogger<IndexModel> logger, CourseService courseService)
    {
        _logger = logger;
        _courseService = courseService;
    }

    public List<Course> AllCourses { get; set; }
    public List<Course> AvailableCourses { get; set; } = new List<Course>();

    [BindProperty]
    public List<string> SelectedCourses { get; set; } = new List<string>();

    public void OnGet()
    {
        AllCourses = _courseService.GetAllCourses();
    }

    public IActionResult OnPost()
    {
        AllCourses = _courseService.GetAllCourses();

        if (SelectedCourses != null && SelectedCourses.Count > 0)
        {
            AvailableCourses = _courseService.GetAvailableCourses(SelectedCourses);
        }

        return Page();
    }
}
