package_dir = File.join(".", "packages");
package_rb_files = File.join(package_dir, "**", "*.rb")

target_dir = File.join(".", "src", "ConsoleApp", "bin", "Debug");
target_dir2 = File.join(".", "src", "ConsoleApp", "bin", "Debug", "toto");

Dir.glob(package_rb_files).each{|x| require_relative x}


#block = Proc.new {
#	copy_files  'native', 'xml'
#	copy_files  'native', ['dll', 'lib'] 
#	copy_file "**/native/*.dll", "**/test/*.dll"
#}

#copy_depdencies package_dir, target_dir, &block

#copy_depdencies package_dir,  [target_dir, target_dir2] do
#	copy_files  'native', 'xml'
#	copy_native_dll
#	copy_files  'native', ['dll', 'lib'] 
#	copy_file "**/native/*.dll", "**/test/*.dll"
#end

copy_depdencies package_dir,  target_dir do
	copy_native_dll
end
