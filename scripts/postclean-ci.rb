require_relative 'include-packages'

def configuration
  ENV['CONFIGURATION'] || "Debug"
end

target_dir = File.join(src_dir, "ConsoleApp", "bin", configuration);
test_dir = File.join(solution_dir, "tests", "ConsoleApp.Tests", "bin", configuration);

copy_depdencies packages_dir,  [target_dir, test_dir] do
	puts "copying to #{target_dir} and #{test_dir}"
  copy_native_dll
end

fragments_dir = File.join(solution_dir, "ConsoleApp.Setup", "fragments");
copy_depdencies packages_dir,  fragments_dir do
	copy_wix_wxs
end

