require_relative 'include-packages'

target_dir = File.join(solution_dir, "src", "ConsoleApp", "bin", "Debug");



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

copy_depdencies packages_dir,  target_dir do
	copy_file  '**/native/**/x86/Debug/*.dll'
end
