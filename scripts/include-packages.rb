def solution_dir
	File.absolute_path(File.join(File.dirname(__FILE__),'..'))
end

def packages_dir
	File.join(solution_dir, "packages");
end

def src_dir
	File.join(solution_dir, "src");
end

packages_rb_files = File.join('.','packages',  'SBSuite.build-scripts*','**', '*.rb')

Dir.glob(packages_rb_files).each{|x|  require_relative x}
