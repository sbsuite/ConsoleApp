package_dir = File.join(".", "packages");
package_rb_files = File.join(package_dir, "**", "*.rb")
Dir.glob(package_rb_files).each{|x|  require_relative x}

def configuration
  ENV['CONFIGURATION'] || "Debug"
end

puts configuration

target_dir = File.join(".", "src", "ConsoleApp", "bin", configuration);

puts package_dir
puts target_dir

copy_depdencies package_dir,  target_dir do
  copy_native_dll
end

puts "done"

