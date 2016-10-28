package_dir = File.join(".", "packages");
package_rb_files = File.join(package_dir, "**", "*.rb")

target_dir = File.join(".", "src", "ConsoleApp", "bin", "Debug");

Dir.glob(package_rb_files).each{|x| require_relative x}

copy_depdencies package_dir,  target_dir do
	copy_files  'native', 'xml'
	copy_files  'native', ['dll', 'lib'] 
	copy_file "**/native/*.dll", "**/test/*.dll"
end	