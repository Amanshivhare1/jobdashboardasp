document.addEventListener('DOMContentLoaded', function () {
  const dateButtons = document.querySelectorAll('.date-btn');
  dateButtons.forEach(btn => {
    btn.addEventListener('click', function () {
      dateButtons.forEach(b => b.classList.remove('bg-blue-500', 'text-white'));
      dateButtons.forEach(b => b.classList.add('bg-gray-200', 'text-gray-800'));
      btn.classList.remove('bg-gray-200', 'text-gray-800');
      btn.classList.add('bg-blue-500', 'text-white');
      // TODO: Fetch jobs for selected date
    });
  });

  document.getElementById('search').addEventListener('input', function (e) {
    // TODO: Filter jobs table based on search
  });

  // TODO: Fetch and render jobs, metrics, and user role
});
