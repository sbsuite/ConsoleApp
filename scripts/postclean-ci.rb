require_relative 'include-packages'

def configuration
  ENV['CONFIGURATION'] || "Release"
end

target_dir = File.join(src_dir, "ConsoleApp", "bin", configuration);
test_dir = File.join(solution_dir, "tests", "ConsoleApp.Tests", "bin", configuration);

#Always copy release DLL's (not platform dependent) on CI
copy_depdencies packages_dir,  [target_dir, test_dir] do
  copy_file  '**/native/**/x86/Release/*.dll'
end

#Copy wix fragment to files
fragments_dir = File.join(solution_dir, "ConsoleApp.Setup", "fragments");
copy_depdencies packages_dir,  fragments_dir do
	copy_wix_wxs
end

